# Fact b6709085

Store id: 85315821-5f80-488d-9876-a50ee2a2a680

## Text

```text
def _check_relation_model_exists(self)
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
- posted_at: `2026-11-09T22:39:44.2537420+00:00`

## Data

```json
{
  "end_line": 217,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 196,
  "symbol": "RelatedField._check_relation_model_exists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":196,"selector":"L196-L217","symbol":"RelatedField._check_relation_model_exists"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_relation_model_exists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 217,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 196,
    "symbol": "RelatedField._check_relation_model_exists"
  },
  "id": "85315821-5f80-488d-9876-a50ee2a2a680",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2537420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 196,
        "selector": "L196-L217",
        "symbol": "RelatedField._check_relation_model_exists"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "f1f08d4d-db5c-4faf-bef0-171b90dc0c9b",
  "subject_name": "django/db/models/fields/related::RelatedField._check_relation_model_exists",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_relation_model_exists(self)"
}
```
