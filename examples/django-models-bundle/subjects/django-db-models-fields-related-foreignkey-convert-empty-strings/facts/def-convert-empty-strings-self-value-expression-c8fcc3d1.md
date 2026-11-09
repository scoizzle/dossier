# Fact c8fcc3d1

Store id: 33f481b5-6292-49d3-8297-4059965d620b

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
- posted_at: `2026-11-09T23:44:51.6089300+00:00`

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
  "id": "33f481b5-6292-49d3-8297-4059965d620b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6089300+00:00"
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
  "subject_id": "59a45ee4-030a-4619-9627-8a17caa8fc43",
  "subject_name": "django/db/models/fields/related::ForeignKey.convert_empty_strings",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_empty_strings(self, value, expression, connection)"
}
```
