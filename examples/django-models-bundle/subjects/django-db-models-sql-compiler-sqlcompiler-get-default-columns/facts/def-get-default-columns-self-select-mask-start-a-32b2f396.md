# Fact 32b2f396

Store id: ffb74d8e-dc2a-4ef5-bd57-0bdf413f0167

## Text

```text
def get_default_columns( self, select_mask, start_alias=None, opts=None, from_parent=None )
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
- posted_at: `2026-11-09T23:44:57.5180030+00:00`

## Data

```json
{
  "end_line": 1051,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1002,
  "symbol": "SQLCompiler.get_default_columns"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1002,"selector":"L1002-L1051","symbol":"SQLCompiler.get_default_columns"}`

## Items

```json
[
  {
    "text": "Compute the default columns for selecting every field in the base model. Will sometimes be called to pull in related models (e.g. via select_related), in which case \"opts\" and \"start_alias\" will be given to provide a starting point for the traversal.",
    "locator": {
      "line": 1005
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_default_columns](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1051,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1002,
    "symbol": "SQLCompiler.get_default_columns"
  },
  "id": "ffb74d8e-dc2a-4ef5-bd57-0bdf413f0167",
  "items": [
    {
      "locator": {
        "line": 1005
      },
      "text": "Compute the default columns for selecting every field in the base model. Will sometimes be called to pull in related models (e.g. via select_related), in which case \"opts\" and \"start_alias\" will be given to provide a starting point for the traversal."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5180030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1002,
        "selector": "L1002-L1051",
        "symbol": "SQLCompiler.get_default_columns"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "e945fcff-d0f1-4530-ada8-b9871675c784",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_default_columns",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default_columns( self, select_mask, start_alias=None, opts=None, from_parent=None )"
}
```
