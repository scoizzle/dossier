# Fact 2026da28

Store id: 68a786cc-b809-4a69-930d-0b89adc4cfe3

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
- posted_at: `2026-11-09T23:31:55.8354250+00:00`

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
  "id": "68a786cc-b809-4a69-930d-0b89adc4cfe3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8354250+00:00"
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
  "subject_id": "5b9538fb-2e7b-49c6-98ca-600d609a385f",
  "subject_name": "django/db/models/expressions::F.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
