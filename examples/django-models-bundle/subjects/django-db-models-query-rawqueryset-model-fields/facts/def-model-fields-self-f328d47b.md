# Fact f328d47b

Store id: 8f52034c-2856-43f6-81d5-889ee35f4aa8

## Text

```text
def model_fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.2726440+00:00`

## Data

```json
{
  "end_line": 2567,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2557,
  "symbol": "RawQuerySet.model_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2557,"selector":"L2557-L2567","symbol":"RawQuerySet.model_fields"}`

## Items

```json
[
  {
    "text": "A dict mapping column names to model field names.",
    "locator": {
      "line": 2559
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.model_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2567,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2557,
    "symbol": "RawQuerySet.model_fields"
  },
  "id": "8f52034c-2856-43f6-81d5-889ee35f4aa8",
  "items": [
    {
      "locator": {
        "line": 2559
      },
      "text": "A dict mapping column names to model field names."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2726440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2557,
        "selector": "L2557-L2567",
        "symbol": "RawQuerySet.model_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "90c03e5d-fc86-44c7-b148-ea3c6c71087f",
  "subject_name": "django/db/models/query::RawQuerySet.model_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def model_fields(self)"
}
```
