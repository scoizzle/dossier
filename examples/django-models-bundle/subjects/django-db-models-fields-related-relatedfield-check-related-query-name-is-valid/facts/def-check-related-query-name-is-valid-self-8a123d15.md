# Fact 8a123d15

Store id: f75fc9a1-82c9-46c3-b926-5ff3f4f7681c

## Text

```text
def _check_related_query_name_is_valid(self)
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
- posted_at: `2026-11-09T23:31:58.6081310+00:00`

## Data

```json
{
  "end_line": 194,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 163,
  "symbol": "RelatedField._check_related_query_name_is_valid"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":163,"selector":"L163-L194","symbol":"RelatedField._check_related_query_name_is_valid"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_related_query_name_is_valid](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 194,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 163,
    "symbol": "RelatedField._check_related_query_name_is_valid"
  },
  "id": "f75fc9a1-82c9-46c3-b926-5ff3f4f7681c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6081310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 163,
        "selector": "L163-L194",
        "symbol": "RelatedField._check_related_query_name_is_valid"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c7b9ac13-9936-48c4-abe1-777dd37b5a7b",
  "subject_name": "django/db/models/fields/related::RelatedField._check_related_query_name_is_valid",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_related_query_name_is_valid(self)"
}
```
