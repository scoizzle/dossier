# Fact 17d8517a

Store id: 47fe4cae-8fbe-46e0-aa33-8c94978ede66

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
- posted_at: `2026-11-09T23:32:01.7690660+00:00`

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
  "id": "47fe4cae-8fbe-46e0-aa33-8c94978ede66",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7690660+00:00"
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
  "subject_id": "3919d92f-71e3-4aba-8d80-f688cc14d18a",
  "subject_name": "django/db/models/functions/math::Sign",
  "tags": [
    "entity:class"
  ],
  "text": "class Sign(Transform)"
}
```
