# Fact fe86be79

Store id: 47097932-3efe-4693-b1a3-ecede725d10e

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
- posted_at: `2026-11-09T23:31:58.7531210+00:00`

## Data

```json
{
  "end_line": 1206,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1188,
  "symbol": "ForeignKey.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1188,"selector":"L1188-L1206","symbol":"ForeignKey.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1206,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1188,
    "symbol": "ForeignKey.deconstruct"
  },
  "id": "47097932-3efe-4693-b1a3-ecede725d10e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7531210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1188,
        "selector": "L1188-L1206",
        "symbol": "ForeignKey.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "7d5b03b3-433b-4366-b3a5-b00029942735",
  "subject_name": "django/db/models/fields/related::ForeignKey.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
