# Fact 3ad3985d

Store id: 807b2f23-a91f-412f-b216-10bd652efb86

## Text

```text
def disconnect(self, receiver=None, sender=None, dispatch_uid=None, apps=None)
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
- posted_at: `2026-11-09T22:39:50.3386540+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "method",
  "parent": "ModelSignal",
  "start_line": 36,
  "symbol": "ModelSignal.disconnect"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/signals.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":36,"selector":"L36-L39","symbol":"ModelSignal.disconnect"}`

## Referenced by

None.

## Subject

[django/db/models/signals::ModelSignal.disconnect](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "method",
    "parent": "ModelSignal",
    "start_line": 36,
    "symbol": "ModelSignal.disconnect"
  },
  "id": "807b2f23-a91f-412f-b216-10bd652efb86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.3386540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 36,
        "selector": "L36-L39",
        "symbol": "ModelSignal.disconnect"
      },
      "rel": "derived_from",
      "target": "django/db/models/signals.py"
    }
  ],
  "status": "live",
  "subject_id": "4bc271f0-1b3c-416a-9029-df47af57d9bb",
  "subject_name": "django/db/models/signals::ModelSignal.disconnect",
  "tags": [
    "entity:method"
  ],
  "text": "def disconnect(self, receiver=None, sender=None, dispatch_uid=None, apps=None)"
}
```
