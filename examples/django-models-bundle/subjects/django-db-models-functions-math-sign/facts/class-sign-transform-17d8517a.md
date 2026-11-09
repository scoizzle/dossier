# Fact 17d8517a

Store id: 977057e5-e93d-496a-8713-45024f5a9261

## Text

```text
class Sign(Transform)
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
- posted_at: `2026-11-09T23:44:53.7699060+00:00`

## Data

```json
{
  "end_line": 199,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 197,
  "symbol": "Sign"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L199","symbol":"Sign"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Sign](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 199,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 197,
    "symbol": "Sign"
  },
  "id": "977057e5-e93d-496a-8713-45024f5a9261",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7699060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L199",
        "symbol": "Sign"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "58570879-1493-46a9-859f-6b8bc748af47",
  "subject_name": "django/db/models/functions/math::Sign",
  "tags": [
    "entity:class"
  ],
  "text": "class Sign(Transform)"
}
```
