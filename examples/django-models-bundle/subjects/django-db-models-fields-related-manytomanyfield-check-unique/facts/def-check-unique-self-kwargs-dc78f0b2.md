# Fact dc78f0b2

Store id: e25f7b7b-35ab-4d98-a910-2c3cc70f38db

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
- posted_at: `2026-11-09T22:39:44.4494710+00:00`

## Data

```json
{
  "end_line": 1556,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1547,
  "symbol": "ManyToManyField._check_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1547,"selector":"L1547-L1556","symbol":"ManyToManyField._check_unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1556,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1547,
    "symbol": "ManyToManyField._check_unique"
  },
  "id": "e25f7b7b-35ab-4d98-a910-2c3cc70f38db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4494710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1547,
        "selector": "L1547-L1556",
        "symbol": "ManyToManyField._check_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "3883f7ef-cb0c-4035-a312-4672d02c47b5",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique(self, **kwargs)"
}
```
