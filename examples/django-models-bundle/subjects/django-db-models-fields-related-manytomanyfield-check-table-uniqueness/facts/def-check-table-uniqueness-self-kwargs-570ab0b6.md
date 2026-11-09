# Fact 570ab0b6

Store id: cf4950ed-f36e-483d-b145-073211665465

## Text

```text
def _check_table_uniqueness(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.4575190+00:00`

## Data

```json
{
  "end_line": 1903,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1853,
  "symbol": "ManyToManyField._check_table_uniqueness"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1853,"selector":"L1853-L1903","symbol":"ManyToManyField._check_table_uniqueness"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_table_uniqueness](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1903,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1853,
    "symbol": "ManyToManyField._check_table_uniqueness"
  },
  "id": "cf4950ed-f36e-483d-b145-073211665465",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4575190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1853,
        "selector": "L1853-L1903",
        "symbol": "ManyToManyField._check_table_uniqueness"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "8c9fa55e-90a0-4c06-9bb1-a8138027f421",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_table_uniqueness",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_table_uniqueness(self, **kwargs)"
}
```
