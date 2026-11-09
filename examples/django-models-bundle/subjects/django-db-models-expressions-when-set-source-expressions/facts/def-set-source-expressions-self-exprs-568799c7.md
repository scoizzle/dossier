# Fact 568799c7

Store id: a4561fe3-c7b4-4654-ae8b-02d716d68252

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:31:55.9509900+00:00`

## Data

```json
{
  "end_line": 1671,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1670,
  "symbol": "When.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1670,"selector":"L1670-L1671","symbol":"When.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1671,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1670,
    "symbol": "When.set_source_expressions"
  },
  "id": "a4561fe3-c7b4-4654-ae8b-02d716d68252",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9509900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1670,
        "selector": "L1670-L1671",
        "symbol": "When.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4ddadb85-af50-4365-a423-dfbe6ba1a8ef",
  "subject_name": "django/db/models/expressions::When.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
