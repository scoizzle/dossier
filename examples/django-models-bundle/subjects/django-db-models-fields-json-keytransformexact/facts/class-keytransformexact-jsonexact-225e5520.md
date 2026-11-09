# Fact 225e5520

Store id: fee46453-0c7c-4986-b4d4-31d02395cfdc

## Text

```text
class KeyTransformExact(JSONExact)
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
- posted_at: `2026-11-09T23:31:57.9991900+00:00`

## Data

```json
{
  "end_line": 663,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 622,
  "symbol": "KeyTransformExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":622,"selector":"L622-L663","symbol":"KeyTransformExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 663,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 622,
    "symbol": "KeyTransformExact"
  },
  "id": "fee46453-0c7c-4986-b4d4-31d02395cfdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9991900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 622,
        "selector": "L622-L663",
        "symbol": "KeyTransformExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "d3ecf5aa-e580-4e5a-b731-4e062b268e02",
  "subject_name": "django/db/models/fields/json::KeyTransformExact",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformExact(JSONExact)"
}
```
