# Fact 1f9fb3bc

Store id: cefc7258-8892-44aa-ae8f-66c5ffe334ae

## Text

```text
def __init__(self, meta, app_label=None)
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
- posted_at: `2026-11-09T22:39:48.7462300+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 115,
  "symbol": "Options.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":115,"selector":"L115-L170","symbol":"Options.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 115,
    "symbol": "Options.__init__"
  },
  "id": "cefc7258-8892-44aa-ae8f-66c5ffe334ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7462300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 115,
        "selector": "L115-L170",
        "symbol": "Options.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "94320082-7bf1-4727-9373-a619505e7b01",
  "subject_name": "django/db/models/options::Options.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, meta, app_label=None)"
}
```
