# Fact e28e84d7

Store id: 0b0aba5c-bf83-42be-ad3c-5667a02f025f

## Text

```text
def __lt__(self, other)
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
- posted_at: `2026-11-09T23:44:49.9949170+00:00`

## Data

```json
{
  "end_line": 740,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 722,
  "symbol": "Field.__lt__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":722,"selector":"L722-L740","symbol":"Field.__lt__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__lt__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 740,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 722,
    "symbol": "Field.__lt__"
  },
  "id": "0b0aba5c-bf83-42be-ad3c-5667a02f025f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9949170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 722,
        "selector": "L722-L740",
        "symbol": "Field.__lt__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c7d11dc5-251f-4635-bdbb-6077885e8abc",
  "subject_name": "django/db/models/fields/__init__::Field.__lt__",
  "tags": [
    "entity:method"
  ],
  "text": "def __lt__(self, other)"
}
```
