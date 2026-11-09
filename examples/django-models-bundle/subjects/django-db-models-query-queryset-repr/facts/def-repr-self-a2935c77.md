# Fact a2935c77

Store id: abb5211d-21b6-4c70-9f8c-483fcb9aca70

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
- posted_at: `2026-11-09T23:32:04.3254800+00:00`

## Data

```json
{
  "end_line": 452,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 448,
  "symbol": "QuerySet.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":448,"selector":"L448-L452","symbol":"QuerySet.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 452,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 448,
    "symbol": "QuerySet.__repr__"
  },
  "id": "abb5211d-21b6-4c70-9f8c-483fcb9aca70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3254800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 448,
        "selector": "L448-L452",
        "symbol": "QuerySet.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e91823d1-6bd9-4732-8373-f1074631a51e",
  "subject_name": "django/db/models/query::QuerySet.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
