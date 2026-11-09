# Fact fd3b60ef

Store id: 67985734-c1d1-4aae-b780-19462ba1b063

## Text

```text
def _check_referencing_to_swapped_model(self)
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
- posted_at: `2026-11-09T23:44:51.4709520+00:00`

## Data

```json
{
  "end_line": 235,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 219,
  "symbol": "RelatedField._check_referencing_to_swapped_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":219,"selector":"L219-L235","symbol":"RelatedField._check_referencing_to_swapped_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_referencing_to_swapped_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 235,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 219,
    "symbol": "RelatedField._check_referencing_to_swapped_model"
  },
  "id": "67985734-c1d1-4aae-b780-19462ba1b063",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4709520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 219,
        "selector": "L219-L235",
        "symbol": "RelatedField._check_referencing_to_swapped_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a4a3ca16-f749-4b43-bf61-a36b4e7d6d7c",
  "subject_name": "django/db/models/fields/related::RelatedField._check_referencing_to_swapped_model",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_referencing_to_swapped_model(self)"
}
```
