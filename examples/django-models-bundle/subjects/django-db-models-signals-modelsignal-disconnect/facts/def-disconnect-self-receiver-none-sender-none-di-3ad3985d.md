# Fact 3ad3985d

Store id: a8732fca-28c9-4d61-a946-83cd693122fa

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
- posted_at: `2026-11-09T23:44:56.9754450+00:00`

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
  "id": "a8732fca-28c9-4d61-a946-83cd693122fa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.9754450+00:00"
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
  "subject_id": "8b6f7fee-1b10-442d-9831-a26a87383cd7",
  "subject_name": "django/db/models/signals::ModelSignal.disconnect",
  "tags": [
    "entity:method"
  ],
  "text": "def disconnect(self, receiver=None, sender=None, dispatch_uid=None, apps=None)"
}
```
