# Fact 4c682c2d

Store id: b88808f0-ca5a-4c75-9b74-ead2dd10188a

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
- posted_at: `2026-11-09T23:31:58.0247750+00:00`

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
  "id": "b88808f0-ca5a-4c75-9b74-ead2dd10188a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0247750+00:00"
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
  "subject_id": "0a0718b2-7821-4f4a-8ae9-545aa9dcd8d0",
  "subject_name": "django/db/models/fields/json::KeyTransformRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformRegex(KeyTransformTextLookupMixin, lookups.Regex)"
}
```
