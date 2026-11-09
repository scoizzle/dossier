# Fact 54626e93

Store id: a9144642-eb8f-4b9f-8b45-947c3e616eb3

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.6923880+00:00`

## Data

```json
{
  "end_line": 1665,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1664,
  "symbol": "When.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1664,"selector":"L1664-L1665","symbol":"When.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1665,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1664,
    "symbol": "When.__repr__"
  },
  "id": "a9144642-eb8f-4b9f-8b45-947c3e616eb3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6923880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1664,
        "selector": "L1664-L1665",
        "symbol": "When.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "64f49755-31c1-492c-a582-7a61ce556dc0",
  "subject_name": "django/db/models/expressions::When.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
