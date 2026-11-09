# Fact 8e89ae9e

Store id: e0cc1abd-e3a0-4473-881b-c2c6d0b0cc85

## Text

```text
def _check_unique(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.6229420+00:00`

## Data

```json
{
  "end_line": 1398,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1396,
  "symbol": "OneToOneField._check_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1396,"selector":"L1396-L1398","symbol":"OneToOneField._check_unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField._check_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1398,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1396,
    "symbol": "OneToOneField._check_unique"
  },
  "id": "e0cc1abd-e3a0-4473-881b-c2c6d0b0cc85",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6229420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1396,
        "selector": "L1396-L1398",
        "symbol": "OneToOneField._check_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "07ae10dc-f69d-451e-ba50-99cbe1fadcea",
  "subject_name": "django/db/models/fields/related::OneToOneField._check_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique(self, **kwargs)"
}
```
