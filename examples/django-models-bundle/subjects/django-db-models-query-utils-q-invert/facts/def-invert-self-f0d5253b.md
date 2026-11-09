# Fact f0d5253b

Store id: 75a6cae1-a27f-4d99-a048-1e51db503f02

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T23:44:56.5594660+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 96,
  "symbol": "Q.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L99","symbol":"Q.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 96,
    "symbol": "Q.__invert__"
  },
  "id": "75a6cae1-a27f-4d99-a048-1e51db503f02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5594660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L99",
        "symbol": "Q.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "d53c1d83-fa07-4f30-a032-e4f0972fd6b8",
  "subject_name": "django/db/models/query_utils::Q.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
