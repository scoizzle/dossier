# Fact 9a3a0530

Store id: 57079d83-e4d5-4788-a040-0e1c63b6e608

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
- posted_at: `2026-11-09T23:44:56.9714080+00:00`

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
  "id": "57079d83-e4d5-4788-a040-0e1c63b6e608",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.9714080+00:00"
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
  "subject_id": "6b972bca-ff6d-4377-b699-85922324622b",
  "subject_name": "django/db/models/signals::ModelSignal.connect",
  "tags": [
    "entity:method"
  ],
  "text": "def connect(self, receiver, sender=None, weak=True, dispatch_uid=None, apps=None)"
}
```
