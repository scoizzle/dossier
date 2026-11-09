# Fact fd62b3ef

Store id: e11fb693-a1e5-4e00-9d22-e9e0b3c8ce47

## Text

```text
def get_attname_column(self)
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
- posted_at: `2026-11-09T22:39:44.4677740+00:00`

## Data

```json
{
  "end_line": 1993,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1991,
  "symbol": "ManyToManyField.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1991,"selector":"L1991-L1993","symbol":"ManyToManyField.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1993,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1991,
    "symbol": "ManyToManyField.get_attname_column"
  },
  "id": "e11fb693-a1e5-4e00-9d22-e9e0b3c8ce47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4677740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1991,
        "selector": "L1991-L1993",
        "symbol": "ManyToManyField.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "235ef129-f865-4c5b-895c-da8bac2ef34a",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
