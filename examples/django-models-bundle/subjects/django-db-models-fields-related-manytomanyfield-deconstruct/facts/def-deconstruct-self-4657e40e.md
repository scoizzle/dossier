# Fact 4657e40e

Store id: a5e59363-207e-4430-a083-57360bfbf306

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:58.8495910+00:00`

## Data

```json
{
  "end_line": 1989,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1949,
  "symbol": "ManyToManyField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1949,"selector":"L1949-L1989","symbol":"ManyToManyField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1989,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1949,
    "symbol": "ManyToManyField.deconstruct"
  },
  "id": "a5e59363-207e-4430-a083-57360bfbf306",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8495910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1949,
        "selector": "L1949-L1989",
        "symbol": "ManyToManyField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "70baa3ab-bccb-4643-9f96-cb41144a3bd4",
  "subject_name": "django/db/models/fields/related::ManyToManyField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
