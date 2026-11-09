# Fact 4c682c2d

Store id: cfce140a-841c-40b1-a265-3e9cfc7f8bfe

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
- posted_at: `2026-11-09T23:44:51.0590120+00:00`

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
  "id": "cfce140a-841c-40b1-a265-3e9cfc7f8bfe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0590120+00:00"
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
  "subject_id": "e16bee8e-b162-4491-b093-e7901e6e8670",
  "subject_name": "django/db/models/fields/json::KeyTransformRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformRegex(KeyTransformTextLookupMixin, lookups.Regex)"
}
```
