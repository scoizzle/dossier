# Fact 570ab0b6

Store id: 826906fc-9157-441f-bb32-af7a1da4074d

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
- posted_at: `2026-11-09T23:31:58.8408530+00:00`

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
  "id": "826906fc-9157-441f-bb32-af7a1da4074d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8408530+00:00"
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
  "subject_id": "b91c9a44-d07e-4adf-8b54-db2a85ec4b43",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_table_uniqueness",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_table_uniqueness(self, **kwargs)"
}
```
