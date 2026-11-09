# Fact bca10c0e

Store id: c74132f6-47f3-4d3c-b93e-9d2124d6e0b5

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
- posted_at: `2026-11-09T23:31:53.7328360+00:00`

## Data

```json
{
  "end_line": 633,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 632,
  "symbol": "Model.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":632,"selector":"L632-L633","symbol":"Model.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 633,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 632,
    "symbol": "Model.__repr__"
  },
  "id": "c74132f6-47f3-4d3c-b93e-9d2124d6e0b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7328360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 632,
        "selector": "L632-L633",
        "symbol": "Model.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "c9a850f2-bf95-40de-8ef2-c215fa8f1b3c",
  "subject_name": "django/db/models/base::Model.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
