# Fact 2026da28

Store id: e76626a6-5f1f-44cc-bcf5-f14a3b0f9c84

## Text

```text
def replace_expressions(self, replacements)
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
- posted_at: `2026-11-09T23:44:49.4801160+00:00`

## Data

```json
{
  "end_line": 928,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 910,
  "symbol": "F.replace_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":910,"selector":"L910-L928","symbol":"F.replace_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.replace_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 928,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 910,
    "symbol": "F.replace_expressions"
  },
  "id": "e76626a6-5f1f-44cc-bcf5-f14a3b0f9c84",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4801160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 910,
        "selector": "L910-L928",
        "symbol": "F.replace_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f0bf1615-3c19-4b55-9eb6-714caac502f2",
  "subject_name": "django/db/models/expressions::F.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
