# Fact 0d2052f3

Store id: 1e5a9662-8aeb-4a2d-8763-0d2750d382b8

## Text

```text
class KeyTransformGte(KeyTransformNumericLookupMixin, lookups.GreaterThanOrEqual)
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
- posted_at: `2026-11-09T23:44:51.0707830+00:00`

## Data

```json
{
  "end_line": 741,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 740,
  "symbol": "KeyTransformGte"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":740,"selector":"L740-L741","symbol":"KeyTransformGte"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformGte](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 741,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 740,
    "symbol": "KeyTransformGte"
  },
  "id": "1e5a9662-8aeb-4a2d-8763-0d2750d382b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0707830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 740,
        "selector": "L740-L741",
        "symbol": "KeyTransformGte"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "d67961c5-7f9c-41dd-89cb-6d7531eeaab0",
  "subject_name": "django/db/models/fields/json::KeyTransformGte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGte(KeyTransformNumericLookupMixin, lookups.GreaterThanOrEqual)"
}
```
