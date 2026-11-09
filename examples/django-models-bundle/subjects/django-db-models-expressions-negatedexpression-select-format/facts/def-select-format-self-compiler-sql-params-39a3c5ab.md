# Fact 39a3c5ab

Store id: 0f007f4e-2552-4db7-855a-b25976588301

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
- posted_at: `2026-11-09T22:39:41.6873230+00:00`

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
  "id": "0f007f4e-2552-4db7-855a-b25976588301",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6873230+00:00"
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
  "subject_id": "f94688df-f9a9-45fe-a7b7-cc33a3a0f2f3",
  "subject_name": "django/db/models/expressions::NegatedExpression.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
