# Fact db913a98

Store id: 23769036-b02e-42c2-bbc2-8866a78f4d2e

## Text

```text
class KeyTransformGt(KeyTransformNumericLookupMixin, lookups.GreaterThan)
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
- posted_at: `2026-11-09T23:31:58.0377050+00:00`

## Data

```json
{
  "end_line": 737,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 736,
  "symbol": "KeyTransformGt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":736,"selector":"L736-L737","symbol":"KeyTransformGt"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformGt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 737,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 736,
    "symbol": "KeyTransformGt"
  },
  "id": "23769036-b02e-42c2-bbc2-8866a78f4d2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0377050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 736,
        "selector": "L736-L737",
        "symbol": "KeyTransformGt"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "a7885cab-8a71-4846-9202-7b2649aa6e90",
  "subject_name": "django/db/models/fields/json::KeyTransformGt",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGt(KeyTransformNumericLookupMixin, lookups.GreaterThan)"
}
```
