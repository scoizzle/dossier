# Fact 9a3a0530

Store id: 48e935e6-8c99-4c9c-96d0-c3a863c40150

## Text

```text
def connect(self, receiver, sender=None, weak=True, dispatch_uid=None, apps=None)
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
- posted_at: `2026-11-09T22:39:50.3354450+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "method",
  "parent": "ModelSignal",
  "start_line": 26,
  "symbol": "ModelSignal.connect"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/signals.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":26,"selector":"L26-L34","symbol":"ModelSignal.connect"}`

## Referenced by

None.

## Subject

[django/db/models/signals::ModelSignal.connect](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "method",
    "parent": "ModelSignal",
    "start_line": 26,
    "symbol": "ModelSignal.connect"
  },
  "id": "48e935e6-8c99-4c9c-96d0-c3a863c40150",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.3354450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 26,
        "selector": "L26-L34",
        "symbol": "ModelSignal.connect"
      },
      "rel": "derived_from",
      "target": "django/db/models/signals.py"
    }
  ],
  "status": "live",
  "subject_id": "526664e9-51de-4255-8ccf-d8ff751ec4c7",
  "subject_name": "django/db/models/signals::ModelSignal.connect",
  "tags": [
    "entity:method"
  ],
  "text": "def connect(self, receiver, sender=None, weak=True, dispatch_uid=None, apps=None)"
}
```
