# Fact 4c682c2d

Store id: 3e363654-3617-4002-aa1b-70be73efbaa9

## Text

```text
class KeyTransformRegex(KeyTransformTextLookupMixin, lookups.Regex)
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
- posted_at: `2026-11-09T22:39:43.7519390+00:00`

## Data

```json
{
  "end_line": 711,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 710,
  "symbol": "KeyTransformRegex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":710,"selector":"L710-L711","symbol":"KeyTransformRegex"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformRegex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 711,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 710,
    "symbol": "KeyTransformRegex"
  },
  "id": "3e363654-3617-4002-aa1b-70be73efbaa9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7519390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 710,
        "selector": "L710-L711",
        "symbol": "KeyTransformRegex"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "5134e9f3-a04b-4a87-b1d7-6bf331a6caca",
  "subject_name": "django/db/models/fields/json::KeyTransformRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformRegex(KeyTransformTextLookupMixin, lookups.Regex)"
}
```
