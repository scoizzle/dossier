# Fact c6afb3f7

Store id: 597ca1e5-7222-4947-bf8c-b453c38d77e5

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:03.9393450+00:00`

## Data

```json
{
  "end_line": 390,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 389,
  "symbol": "Options.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":389,"selector":"L389-L390","symbol":"Options.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 390,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 389,
    "symbol": "Options.__repr__"
  },
  "id": "597ca1e5-7222-4947-bf8c-b453c38d77e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9393450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 389,
        "selector": "L389-L390",
        "symbol": "Options.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "69dafc93-fd1c-4bad-879e-93f9cb72e513",
  "subject_name": "django/db/models/options::Options.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
