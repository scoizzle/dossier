# Fact c8fcc3d1

Store id: 30765d4c-64c4-40e3-9b37-74ea808c3747

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
- posted_at: `2026-11-09T23:31:58.7915520+00:00`

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
  "id": "30765d4c-64c4-40e3-9b37-74ea808c3747",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7915520+00:00"
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
  "subject_id": "b034cc4c-ae90-4b35-b895-0c193ddf0886",
  "subject_name": "django/db/models/fields/related::ForeignKey.convert_empty_strings",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_empty_strings(self, value, expression, connection)"
}
```
