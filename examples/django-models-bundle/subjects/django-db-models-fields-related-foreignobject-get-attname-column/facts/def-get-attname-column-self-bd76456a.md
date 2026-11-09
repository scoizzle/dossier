# Fact bd76456a

Store id: 8d917cbc-916c-4d2b-8a2a-a2dbfd80d9ad

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
- posted_at: `2026-11-09T23:31:58.7021900+00:00`

## Data

```json
{
  "end_line": 852,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 850,
  "symbol": "ForeignObject.get_attname_column"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":850,"selector":"L850-L852","symbol":"ForeignObject.get_attname_column"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_attname_column](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 852,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 850,
    "symbol": "ForeignObject.get_attname_column"
  },
  "id": "8d917cbc-916c-4d2b-8a2a-a2dbfd80d9ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7021900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 850,
        "selector": "L850-L852",
        "symbol": "ForeignObject.get_attname_column"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "0ce87723-2b1a-47e4-8445-8945a8527225",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_attname_column",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname_column(self)"
}
```
