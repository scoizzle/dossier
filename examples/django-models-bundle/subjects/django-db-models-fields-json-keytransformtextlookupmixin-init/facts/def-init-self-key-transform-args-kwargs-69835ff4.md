# Fact 69835ff4

Store id: a712d53f-17ea-4465-bd44-7f65cfe387ef

## Text

```text
def __init__(self, key_transform, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.7234930+00:00`

## Data

```json
{
  "end_line": 591,
  "entity_kind": "method",
  "parent": "KeyTransformTextLookupMixin",
  "start_line": 580,
  "symbol": "KeyTransformTextLookupMixin.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":580,"selector":"L580-L591","symbol":"KeyTransformTextLookupMixin.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformTextLookupMixin.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 591,
    "entity_kind": "method",
    "parent": "KeyTransformTextLookupMixin",
    "start_line": 580,
    "symbol": "KeyTransformTextLookupMixin.__init__"
  },
  "id": "a712d53f-17ea-4465-bd44-7f65cfe387ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7234930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 580,
        "selector": "L580-L591",
        "symbol": "KeyTransformTextLookupMixin.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "2e5beb3e-8415-4692-99e7-2e3c6797de74",
  "subject_name": "django/db/models/fields/json::KeyTransformTextLookupMixin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, key_transform, *args, **kwargs)"
}
```
