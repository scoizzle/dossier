# Fact f0ba87bf

Store id: 38ac9596-4af6-4afb-b01f-80e1f6b6a4c8

## Text

```text
class LPad(Func)
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
- posted_at: `2026-11-09T23:32:02.2085820+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 197,
  "symbol": "LPad"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L208","symbol":"LPad"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::LPad](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 197,
    "symbol": "LPad"
  },
  "id": "38ac9596-4af6-4afb-b01f-80e1f6b6a4c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2085820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L208",
        "symbol": "LPad"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "0289256f-1789-470e-8da5-e017e8a76dbb",
  "subject_name": "django/db/models/functions/text::LPad",
  "tags": [
    "entity:class"
  ],
  "text": "class LPad(Func)"
}
```
