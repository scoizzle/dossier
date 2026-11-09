# Fact 2ec0bbf1

Store id: 0fbf285f-f452-43ef-84d1-c066d965061c

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
- posted_at: `2026-11-09T23:31:55.8831090+00:00`

## Data

```json
{
  "end_line": 1325,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1324,
  "symbol": "DatabaseDefault.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1324,"selector":"L1324-L1325","symbol":"DatabaseDefault.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1325,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1324,
    "symbol": "DatabaseDefault.set_source_expressions"
  },
  "id": "0fbf285f-f452-43ef-84d1-c066d965061c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8831090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1324,
        "selector": "L1324-L1325",
        "symbol": "DatabaseDefault.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3ba1c4d4-546a-4b24-8292-177c4ea64314",
  "subject_name": "django/db/models/expressions::DatabaseDefault.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
