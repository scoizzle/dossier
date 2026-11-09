# Fact fe5309ab

Store id: 375ab4f4-23ab-4138-824e-4a9b3fcefe03

## Text

```text
class Col(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8880830+00:00`

## Data

```json
{
  "end_line": 1387,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1351,
  "symbol": "Col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"selector":"L1351-L1387","symbol":"Col"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1387,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1351,
    "symbol": "Col"
  },
  "id": "375ab4f4-23ab-4138-824e-4a9b3fcefe03",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8880830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1351,
        "selector": "L1351-L1387",
        "symbol": "Col"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2ff85bdc-fc0c-4e9f-b042-495e5ed32353",
  "subject_name": "django/db/models/expressions::Col",
  "tags": [
    "entity:class"
  ],
  "text": "class Col(Expression)"
}
```
