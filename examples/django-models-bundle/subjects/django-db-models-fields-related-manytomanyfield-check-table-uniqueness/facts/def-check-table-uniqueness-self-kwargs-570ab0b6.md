# Fact 570ab0b6

Store id: 5b314da5-2672-43df-85a2-505d8b5b3c3b

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
- posted_at: `2026-11-09T23:44:51.6400840+00:00`

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
  "id": "5b314da5-2672-43df-85a2-505d8b5b3c3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6400840+00:00"
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
  "subject_id": "31547fbc-bfa7-4bc8-9614-3aea7e8f8979",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_table_uniqueness",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_table_uniqueness(self, **kwargs)"
}
```
