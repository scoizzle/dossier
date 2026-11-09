# Fact f6f46467

Store id: 9ea6b0d7-87e1-4a98-927d-ff2e4246d0f5

## Text

```text
class Expression(BaseExpression, Combinable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.7971080+00:00`

## Data

```json
{
  "end_line": 562,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 519,
  "symbol": "Expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":519,"selector":"L519-L562","symbol":"Expression"}`

## Items

```json
[
  {
    "text": "An expression that can be combined with other expressions.",
    "locator": {
      "line": 521
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 562,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 519,
    "symbol": "Expression"
  },
  "id": "9ea6b0d7-87e1-4a98-927d-ff2e4246d0f5",
  "items": [
    {
      "locator": {
        "line": 521
      },
      "text": "An expression that can be combined with other expressions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7971080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 519,
        "selector": "L519-L562",
        "symbol": "Expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ba9b11a9-892f-47d5-96a1-dbbf82ab43be",
  "subject_name": "django/db/models/expressions::Expression",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class Expression(BaseExpression, Combinable)"
}
```
