# Fact 2026da28

Store id: 95ef316b-c17c-4405-ae3a-592d0f5f2212

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
- posted_at: `2026-11-09T22:39:41.5624820+00:00`

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
  "id": "95ef316b-c17c-4405-ae3a-592d0f5f2212",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5624820+00:00"
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
  "subject_id": "18357dbb-ec61-44c7-8c55-05e642f64db1",
  "subject_name": "django/db/models/expressions::F.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
