# Fact 0d2052f3

Store id: 9a96b212-f84b-425a-9ced-4c25f62fa075

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
- posted_at: `2026-11-09T23:31:58.0398480+00:00`

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
  "id": "9a96b212-f84b-425a-9ced-4c25f62fa075",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0398480+00:00"
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
  "subject_id": "fba312f7-34c4-4101-bbf9-4c49be8ac12f",
  "subject_name": "django/db/models/fields/json::KeyTransformGte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGte(KeyTransformNumericLookupMixin, lookups.GreaterThanOrEqual)"
}
```
