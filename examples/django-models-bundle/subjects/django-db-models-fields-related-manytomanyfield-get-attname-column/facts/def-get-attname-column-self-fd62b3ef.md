# Fact fd62b3ef

Store id: 4ec5c632-0342-4376-91f7-5ded44496835

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
- posted_at: `2026-11-09T23:31:58.8555950+00:00`

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
  "id": "4ec5c632-0342-4376-91f7-5ded44496835",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8555950+00:00"
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
  "subject_id": "5a623aeb-d9ac-417e-b717-9f4ba085fb8e",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
