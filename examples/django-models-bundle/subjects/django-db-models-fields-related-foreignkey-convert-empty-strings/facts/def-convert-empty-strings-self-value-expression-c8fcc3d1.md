# Fact c8fcc3d1

Store id: 5c9692f1-d682-44bb-a8e7-a1e66a79b1c0

## Text

```text
def convert_empty_strings(self, value, expression, connection)
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
- posted_at: `2026-11-09T22:39:44.4181670+00:00`

## Data

```json
{
  "end_line": 1333,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1330,
  "symbol": "ForeignKey.convert_empty_strings"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1330,"selector":"L1330-L1333","symbol":"ForeignKey.convert_empty_strings"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.convert_empty_strings](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1333,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1330,
    "symbol": "ForeignKey.convert_empty_strings"
  },
  "id": "5c9692f1-d682-44bb-a8e7-a1e66a79b1c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4181670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1330,
        "selector": "L1330-L1333",
        "symbol": "ForeignKey.convert_empty_strings"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5c118e96-7756-4f4d-93cf-912edde0834c",
  "subject_name": "django/db/models/fields/related::ForeignKey.convert_empty_strings",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_empty_strings(self, value, expression, connection)"
}
```
