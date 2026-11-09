# Fact 7e2eaf79

Store id: ecbc1300-ebd3-4f1e-9b1c-8dfae040e25a

## Text

```text
def get_exclusion(self)
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
- posted_at: `2026-11-09T23:31:56.0226850+00:00`

## Data

```json
{
  "end_line": 2167,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2164,
  "symbol": "WindowFrame.get_exclusion"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2164,"selector":"L2164-L2167","symbol":"WindowFrame.get_exclusion"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.get_exclusion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2167,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2164,
    "symbol": "WindowFrame.get_exclusion"
  },
  "id": "ecbc1300-ebd3-4f1e-9b1c-8dfae040e25a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0226850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2164,
        "selector": "L2164-L2167",
        "symbol": "WindowFrame.get_exclusion"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cd91fa85-0de4-4b42-9991-afa6933c5754",
  "subject_name": "django/db/models/expressions::WindowFrame.get_exclusion",
  "tags": [
    "entity:method"
  ],
  "text": "def get_exclusion(self)"
}
```
