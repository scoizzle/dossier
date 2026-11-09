# Fact e46816cb

Store id: 2ff9bf57-8b76-44fd-b67c-d9523035d8ce

## Text

```text
def get_col(self, alias, output_field=None)
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
- posted_at: `2026-11-09T22:39:42.2895200+00:00`

## Data

```json
{
  "end_line": 581,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 574,
  "symbol": "Field.get_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":574,"selector":"L574-L581","symbol":"Field.get_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 581,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 574,
    "symbol": "Field.get_col"
  },
  "id": "2ff9bf57-8b76-44fd-b67c-d9523035d8ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2895200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 574,
        "selector": "L574-L581",
        "symbol": "Field.get_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7c07ffa0-98cf-43bc-9e47-25671c0040bb",
  "subject_name": "django/db/models/fields/__init__::Field.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```
