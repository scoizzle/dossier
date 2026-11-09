# Fact a2935c77

Store id: a645e7d8-eaa5-4d7a-b505-ef79ff94b0c9

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
- posted_at: `2026-11-09T22:39:49.3153470+00:00`

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
  "id": "a645e7d8-eaa5-4d7a-b505-ef79ff94b0c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3153470+00:00"
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
  "subject_id": "30cfc4b3-e12e-4388-be1b-ac85ab86d156",
  "subject_name": "django/db/models/query::QuerySet.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
