# Fact c6afb3f7

Store id: 43519ff3-dedd-4080-8388-2b9be69eb053

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
- posted_at: `2026-11-09T23:44:55.4987990+00:00`

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
  "id": "43519ff3-dedd-4080-8388-2b9be69eb053",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4987990+00:00"
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
  "subject_id": "6a360d70-ec0b-46ef-a12c-2f2a00b0909b",
  "subject_name": "django/db/models/options::Options.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
