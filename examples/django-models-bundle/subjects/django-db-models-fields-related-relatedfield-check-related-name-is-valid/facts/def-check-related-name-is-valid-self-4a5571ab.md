# Fact 4a5571ab

Store id: f46eae35-ebdc-4320-a9d6-3764e487be22

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
- posted_at: `2026-11-09T23:44:51.4657200+00:00`

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
  "id": "f46eae35-ebdc-4320-a9d6-3764e487be22",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4657200+00:00"
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
  "subject_id": "108c1e1e-7bb7-4e28-908c-73c49dad677b",
  "subject_name": "django/db/models/fields/related::RelatedField._check_related_name_is_valid",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_related_name_is_valid(self)"
}
```
