# Fact b6709085

Store id: 469a3894-6eb1-4775-b58f-cbcaffc47b6d

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
- posted_at: `2026-11-09T23:44:51.4692140+00:00`

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
  "id": "469a3894-6eb1-4775-b58f-cbcaffc47b6d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4692140+00:00"
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
  "subject_id": "57fe9be3-bb77-4cb4-82a0-03ecf83f7581",
  "subject_name": "django/db/models/fields/related::RelatedField._check_relation_model_exists",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_relation_model_exists(self)"
}
```
