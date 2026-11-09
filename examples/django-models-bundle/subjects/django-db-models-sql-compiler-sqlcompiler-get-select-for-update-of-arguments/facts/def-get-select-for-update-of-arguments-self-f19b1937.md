# Fact f19b1937

Store id: 91843b14-2ecf-4032-9f59-b074c38ebf38

## Text

```text
def get_select_for_update_of_arguments(self)
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
- posted_at: `2026-11-09T22:39:50.6539590+00:00`

## Data

```json
{
  "end_line": 1530,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1426,
  "symbol": "SQLCompiler.get_select_for_update_of_arguments"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1426,"selector":"L1426-L1530","symbol":"SQLCompiler.get_select_for_update_of_arguments"}`

## Items

```json
[
  {
    "text": "Return a quoted list of arguments for the SELECT FOR UPDATE OF part of the query.",
    "locator": {
      "line": 1427
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1530,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1426,
    "symbol": "SQLCompiler.get_select_for_update_of_arguments"
  },
  "id": "91843b14-2ecf-4032-9f59-b074c38ebf38",
  "items": [
    {
      "locator": {
        "line": 1427
      },
      "text": "Return a quoted list of arguments for the SELECT FOR UPDATE OF part of the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6539590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1426,
        "selector": "L1426-L1530",
        "symbol": "SQLCompiler.get_select_for_update_of_arguments"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "be95ddb1-e8fa-4a50-8218-0e286c58f3c2",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments",
  "tags": [
    "entity:method"
  ],
  "text": "def get_select_for_update_of_arguments(self)"
}
```
