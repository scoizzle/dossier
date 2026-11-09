# Fact 69835ff4

Store id: 6362b314-d136-4698-849a-2a3b8f53dded

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
- posted_at: `2026-11-09T23:31:57.9895350+00:00`

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
  "id": "6362b314-d136-4698-849a-2a3b8f53dded",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9895350+00:00"
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
  "subject_id": "791d41e7-a474-4d59-9418-9c06ecf69cd8",
  "subject_name": "django/db/models/fields/json::KeyTransformTextLookupMixin.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, key_transform, *args, **kwargs)"
}
```
