# Fact d5f49f79

Store id: 78e1bd7d-a5ae-410d-a99f-b39c799f82fb

## Text

```text
class KeyTransformIn(JSONIn)
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
- posted_at: `2026-11-09T23:31:57.9972590+00:00`

## Data

```json
{
  "end_line": 619,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 618,
  "symbol": "KeyTransformIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":618,"selector":"L618-L619","symbol":"KeyTransformIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 619,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 618,
    "symbol": "KeyTransformIn"
  },
  "id": "78e1bd7d-a5ae-410d-a99f-b39c799f82fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9972590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 618,
        "selector": "L618-L619",
        "symbol": "KeyTransformIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "34f32a3e-7a86-44de-8ae8-3a631eed5b0c",
  "subject_name": "django/db/models/fields/json::KeyTransformIn",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIn(JSONIn)"
}
```
