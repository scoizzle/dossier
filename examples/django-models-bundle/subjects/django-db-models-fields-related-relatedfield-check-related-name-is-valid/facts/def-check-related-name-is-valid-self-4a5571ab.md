# Fact 4a5571ab

Store id: ab108008-394e-4664-8767-7ec25bd366e7

## Text

```text
def _check_related_name_is_valid(self)
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
- posted_at: `2026-11-09T23:31:58.6063210+00:00`

## Data

```json
{
  "end_line": 161,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 135,
  "symbol": "RelatedField._check_related_name_is_valid"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L161","symbol":"RelatedField._check_related_name_is_valid"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_related_name_is_valid](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 161,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 135,
    "symbol": "RelatedField._check_related_name_is_valid"
  },
  "id": "ab108008-394e-4664-8767-7ec25bd366e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6063210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L161",
        "symbol": "RelatedField._check_related_name_is_valid"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "4f58d688-8a31-47dc-8746-072deb5db97b",
  "subject_name": "django/db/models/fields/related::RelatedField._check_related_name_is_valid",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_related_name_is_valid(self)"
}
```
