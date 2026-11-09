# Fact 39a3c5ab

Store id: 5d54facc-c754-47c3-9098-8a92fa10b260

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T23:31:55.9438250+00:00`

## Data

```json
{
  "end_line": 1632,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1619,
  "symbol": "NegatedExpression.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1619,"selector":"L1619-L1632","symbol":"NegatedExpression.select_format"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1632,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1619,
    "symbol": "NegatedExpression.select_format"
  },
  "id": "5d54facc-c754-47c3-9098-8a92fa10b260",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9438250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1619,
        "selector": "L1619-L1632",
        "symbol": "NegatedExpression.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "05ea8b59-812c-4977-a262-142e1b359dd1",
  "subject_name": "django/db/models/expressions::NegatedExpression.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
