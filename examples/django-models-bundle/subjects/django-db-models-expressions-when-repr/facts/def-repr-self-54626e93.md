# Fact 54626e93

Store id: df0f366c-20bd-4f49-8a81-17b0ead3bb72

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
- posted_at: `2026-11-09T23:31:55.9481240+00:00`

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
  "id": "df0f366c-20bd-4f49-8a81-17b0ead3bb72",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9481240+00:00"
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
  "subject_id": "35e9a245-6a32-491f-9632-13b1ba11654c",
  "subject_name": "django/db/models/expressions::When.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
