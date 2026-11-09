# Fact 2c34d042

Store id: 7d859d6c-a016-476e-9a92-04983cf9bd3a

## Text

```text
def compile(self, side, compiler, connection)
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
- posted_at: `2026-11-09T23:31:55.8217620+00:00`

## Data

```json
{
  "end_line": 825,
  "entity_kind": "method",
  "parent": "DurationExpression",
  "start_line": 816,
  "symbol": "DurationExpression.compile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":816,"selector":"L816-L825","symbol":"DurationExpression.compile"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DurationExpression.compile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 825,
    "entity_kind": "method",
    "parent": "DurationExpression",
    "start_line": 816,
    "symbol": "DurationExpression.compile"
  },
  "id": "7d859d6c-a016-476e-9a92-04983cf9bd3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8217620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 816,
        "selector": "L816-L825",
        "symbol": "DurationExpression.compile"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ef0ee091-ef34-44fb-8ac6-b5ad9d43cd79",
  "subject_name": "django/db/models/expressions::DurationExpression.compile",
  "tags": [
    "entity:method"
  ],
  "text": "def compile(self, side, compiler, connection)"
}
```
