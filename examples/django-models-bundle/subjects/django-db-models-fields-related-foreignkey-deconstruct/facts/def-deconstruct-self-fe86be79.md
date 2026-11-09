# Fact fe86be79

Store id: 5c324862-2251-4185-88a3-b3da72f16470

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:44.3816240+00:00`

## Data

```json
{
  "end_line": 1206,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1188,
  "symbol": "ForeignKey.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1188,"selector":"L1188-L1206","symbol":"ForeignKey.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1206,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1188,
    "symbol": "ForeignKey.deconstruct"
  },
  "id": "5c324862-2251-4185-88a3-b3da72f16470",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3816240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1188,
        "selector": "L1188-L1206",
        "symbol": "ForeignKey.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "f725bc1c-d967-4ead-870c-7ab553ed13c6",
  "subject_name": "django/db/models/fields/related::ForeignKey.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
